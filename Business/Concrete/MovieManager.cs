using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Business.Concrete
{
    public class MovieManager : ManagerBaseRepository<Movie>, IMovieService
    {
        public MovieManager(HttpClient client, string baseAddress, UserForLoginModel user) : base(client, baseAddress, user)
        {
        }

        public List<Movie> GetByActor(int actorId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbyactor?id=" + actorId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Movie>>(data);

            return result;
        }

        public List<Movie> GetByDirector(int directorId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbydirector?id=" + directorId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Movie>>(data);

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

        public MovieResponseModel GetMovieById(int movieId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getmoviebyId?id=" + movieId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<MovieResponseModel>(data);

            return result;
        }

        public List<MovieResponseModel> GetMovies()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getmovies").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<MovieResponseModel>>(data);

            return result;
        }

        public List<MovieResponseModel> GetPopularMovies()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getpopularmovies").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<MovieResponseModel>>(data);

            return result;
        }

        public MovieResponseModel GetRandomMovie()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getrandommovie").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<MovieResponseModel>(data);

            return result;
        }
    }
}
