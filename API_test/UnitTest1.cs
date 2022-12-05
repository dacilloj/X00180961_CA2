using Domain;
using Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X00180961_CA2.Controllers;
using System.Net.Http.Headers;
using System.Net.Http;
using System;
using System.Collections.Generic;

namespace API_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7117/");
                    client.DefaultRequestHeaders.
                    Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    
                    HttpResponseMessage response = await client.GetAsync("api/products");

                    Assert.IsNull(response);
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
