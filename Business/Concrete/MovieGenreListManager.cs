﻿using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Business.Concrete
{
    public class MovieGenreListManager : ManagerBaseRepository<MovieGenreList>, IMovieGenreListService
    {
        public MovieGenreListManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public void DeleteByMovie(int recordId)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/deletebymovie?=" + recordId, new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }

        public List<MovieGenreList> GetByMovie(int recordId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbymovie?id=" + recordId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<MovieGenreList>>(data);

            return result;
        }

        public List<MovieGenreList> UpdateByMovie(List<MovieGenreList> list)
        {
            TokenCheck();
            var json = JsonConvert.SerializeObject(list);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"updatebymovie", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<MovieGenreList>>(data);

            return result;
        }
    }
}
