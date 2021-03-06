﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gis2Gis;
using Gis2Gis.Config;
using Newtonsoft.Json;

namespace Gis2Gis.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    [HttpGet]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Index(string query)
    {
      string url = ApiSettings.ApiUrl +
                   @"/search?what=" + query +
                   "&where=Томск&version=1.3&key=" + ApiSettings.ApiKey;
      //TODO Надо как то запрос сделать чтоб он вернул Json

      using (var w = new WebClient())
      {
        var jsonString = string.Empty;
        // attempt to download JSON data as a string
        try
        {
          jsonString = w.DownloadString(url);
          
          ViewBag.Json = jsonString;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
          return null;
        }

        return View();
      }
    }

  }
} 