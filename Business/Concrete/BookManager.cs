using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Business.Concrete
{
    public class BookManager : ManagerBaseRepository<Book>, IBookService
    {
        public BookManager(HttpClient client, string baseAddress, UserForLoginModel user) : base(client, baseAddress, user)
        {
        }

        public BookResponseModel GetBookById(int bookId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbookbyid?id=" + bookId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<BookResponseModel>(data);

            return result;
        }

        public List<BookResponseModel> GetBooks()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbooks").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<BookResponseModel>>(data);

            return result;
        }

        public List<Book> GetByAuthor(int authorId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbyauthor?id=" + authorId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Book>>(data);

            return result;
        }

        public string GetMaxMinValues()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getmaxminvalue").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<string>(data);

            return result;
        }

        public BookResponseModel GetRandomBook()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getrandombook").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<BookResponseModel>(data);

            return result;
        }
    }
}
