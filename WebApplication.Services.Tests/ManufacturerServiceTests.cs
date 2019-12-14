using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using WebApplication.Data;
using WebApplication.Data.Repositories;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;
using WebApplication.Data.Models;

namespace WebApplication.Services.Tests
{
    [TestFixture]
    public class ManufacturerServiceTests
    {

        private IManufacturerService _manufacturerService;

        public ManufacturerServiceTests()
        {
            
        }


        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: "Factory")
                .Options;
            var context = new MyDbContext(options);
            context.Database.EnsureCreated();
            _manufacturerService = new ManufacturerService(new MyDataProvider(context));
        }


        //todo: fix test
        [TestCase("488GTB", "FERRARI")]
        [TestCase("A8ハイブリッド", "AUDI")]
        [TestCase("エテルナ", "MITSUBISHI")]
        [TestCase("スプリンタートレノ", "TOYOTA")]
        [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
        public void CanIdentifyManufacturer(string value, string expected)
        {
            var result = _manufacturerService.GetManufacturerByModel(value);
            Assert.AreEqual(result, expected);
        }
    }
}
