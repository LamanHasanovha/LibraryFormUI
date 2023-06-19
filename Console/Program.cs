using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var rec = new Recommender();

            //var books = new List<Book>(new Book[]
            //{
            //    new Book(1),
            //    new Book(2),
            //    new Book(3),
            //    new Book(4),
            //    new Book(5),
            //    new Book(6),
            //    new Book(7),
            //    new Book(8),
            //    new Book(9)
            //});

            //var accounts = new List<Account>(new Account[]
            //{
            //    new Account(1),
            //    new Account(2),
            //    new Account(3),
            //    new Account(4),
            //    new Account(5),
            //    new Account(6),
            //    new Account(7),
            //    new Account(8),
            //    new Account(9)
            //});

            //var ratings = new List<Rating>(new Rating[]
            //{
            //    new Rating(1,1,1,3),
            //    new Rating(2,1,2,5),
            //    new Rating(3,1,5,4),
            //    new Rating(4,1,9,1),
            //    new Rating(5,1,7,2),
            //    new Rating(6,2,2,3),
            //    new Rating(7,2,9,5),
            //    new Rating(8,2,1,4),
            //    new Rating(9,2,5,1),
            //    new Rating(10,2,3,2),
            //    new Rating(11,3,1,3),
            //    new Rating(12,3,8,1),
            //    new Rating(13,3,6,2),
            //    new Rating(14,3,3,5),
            //    new Rating(15,3,2,4),
            //    new Rating(16,4,8,3),
            //    new Rating(17,4,9,2),
            //    new Rating(18,4,7,1),
            //    new Rating(19,4,1,4),
            //    new Rating(20,4,6,5),
            //    new Rating(21,5,3,3),
            //    new Rating(22,5,4,4),
            //    new Rating(23,5,5,5),
            //    new Rating(24,5,6,2),
            //    new Rating(25,5,8,1)
            //});

            //var result = rec.Train(books, accounts, ratings);

            //foreach (var item in result)
            //{
            //    System.Console.WriteLine(item.Id + " " + item.ItemOneId + " " + item.ItemTwoId + " " + item.Similarity);
            //}

            System.Console.WriteLine("str".Split('|').Length);

            System.Console.ReadLine();
        }
    }

    class Recommender
    {
        public List<ItemBased> Train(List<Book> books, List<Account> accounts, List<Rating> ratings)
        {
            var result = new List<ItemBased>();
            int id = 1;
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = i + 1; j < books.Count; j++)
                {
                    // books[i] books[j]
                    var filteredRatings = ratings.Where(r => r.BookId == books[i].Id | r.BookId == books[j].Id).ToList();
                    var filteredAccounts = filteredRatings.Select(r => r.AccountId).Distinct().ToList();
                    foreach (var account in filteredAccounts)
                    {
                        if (filteredRatings.Where(r => r.AccountId == account & r.Value > 0).Count() < 2)
                            filteredRatings.RemoveAll(r => r.AccountId == account);
                    }

                    if (filteredRatings.Count > 2)
                    {
                        var item = new ItemBased
                        {
                            Id = id,
                            ItemOneId = books[i].Id,
                            ItemTwoId = books[j].Id,
                            Similarity = ComputeSimilarity
                                               (filteredRatings.Where(r => r.BookId == books[i].Id).Select(r => r.Value).ToArray(),
                                                filteredRatings.Where(r => r.BookId == books[j].Id).Select(r => r.Value).ToArray())
                        };

                        result.Add(item);
                    }
                    id++;
                }
            }

            var computedRatings = new List<Rating>();
            id = ratings.Last().Id + 1;
            for (int i = 0; i < accounts.Count; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if (ratings.Any(r => r.AccountId == accounts[i].Id & r.BookId == books[j].Id))
                        continue;

                    var filteredRatings = ratings.Where(r => r.AccountId == accounts[i].Id).ToList();
                    double numerator = 0, denominator = 0;
                    for (int k = 0; k < books.Count; k++)
                    {
                        if (k == j | ratings.FirstOrDefault(rating => rating.AccountId == accounts[i].Id & rating.BookId == books[k].Id) == null)
                            continue;
                        var similarity = result.FirstOrDefault(b => b.ItemOneId == Math.Min(books[j].Id, books[k].Id) & b.ItemTwoId == Math.Max(books[j].Id, books[k].Id)) ?? new ItemBased { Similarity = 0 };
                        denominator += similarity.Similarity;
                        numerator += similarity.Similarity * ratings.FirstOrDefault(rating => rating.AccountId == accounts[i].Id & rating.BookId == books[k].Id).Value;
                    }

                    var generatedRating = new Rating
                    {
                        Id = id,
                        AccountId = accounts[i].Id,
                        BookId = books[j].Id,
                        Value = denominator == 0 ? 0 : (int)Math.Round(numerator / denominator)
                    };
                    computedRatings.Add(generatedRating);
                    id++;
                }
            } 
            ratings.AddRange(computedRatings);
            id = 1;
            foreach (var item in result)
            {
                System.Console.WriteLine(item.Id + " " + item.ItemOneId + " " + item.ItemTwoId + " " + item.Similarity);
            }
            System.Console.WriteLine("-----------------------------------------------------------------");
            result.Clear();
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = i + 1; j < books.Count; j++)
                {
                    // books[i] books[j]
                    var filteredRatings = ratings.Where(r => r.BookId == books[i].Id | r.BookId == books[j].Id).ToList();
                    var filteredAccounts = filteredRatings.Select(r => r.AccountId).Distinct().ToList();
                    foreach (var account in filteredAccounts)
                    {
                        if (filteredRatings.Where(r => r.AccountId == account & r.Value > 0).Count() < 2)
                            filteredRatings.RemoveAll(r => r.AccountId == account);
                    }

                    if (filteredRatings.Count > 2)
                    {
                        var item = new ItemBased
                        {
                            Id = id,
                            ItemOneId = books[i].Id,
                            ItemTwoId = books[j].Id,
                            Similarity = ComputeSimilarity
                                               (filteredRatings.Where(r => r.BookId == books[i].Id).Select(r => r.Value).ToArray(),
                                                filteredRatings.Where(r => r.BookId == books[j].Id).Select(r => r.Value).ToArray())
                        };

                        result.Add(item);
                    }
                    id++;
                }
            }

            return result;
        }

        private double ComputeSimilarity(int[] vector1, int[] vector2)
        {
            double result = MultiplyVectors(vector1, vector2) / (AbsVector(vector1) * AbsVector(vector2));

            return result;
        }

        private double MultiplyVectors(int[] vector1, int[] vector2)
        {
            double result = 0;

            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }

            return result;
        }

        private double AbsVector(int[] vector)
        {
            double result = 0;

            foreach (var item in vector)
            {
                result += Math.Pow(item, 2);
            }

            return Math.Sqrt(result);
        }
    }

    class Book
    {
        public Book(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }

    class Account
    {
        public Account(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }

    class Rating
    {
        public Rating() { }
        public Rating(int id, int accountId, int bookId, int value)
        {
            Id = id;
            AccountId = accountId;
            BookId = bookId;
            Value = value;
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BookId { get; set; }
        public int Value { get; set; }
    }

    class ItemBased
    {
        public int Id { get; set; }
        public int ItemOneId { get; set; }
        public int ItemTwoId { get; set; }
        public double Similarity { get; set; }
    }
}
