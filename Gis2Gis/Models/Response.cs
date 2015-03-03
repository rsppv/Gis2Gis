using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gis2Gis.Models
{
  public class Response
    {
      public string api_version { get; set; }
      public string response_code { get; set; }
      public string what { get; set; }
      public string where { get; set; }
      public int total { get; set; }
      public Did_You_Mean did_you_mean { get; set; }
      public Result[] result { get; set; }
    }

  public class Did_You_Mean
  {
    public Rubric[] rubrics { get; set; }
    public Geo[] geo { get; set; }
  }

  public class Rubric
  {
    public string name { get; set; }
  }

  public class Geo
  {
    public string id { get; set; }
    public string name { get; set; }
  }

  public class Result
  {
    public string id { get; set; }
    public string lon { get; set; }
    public string lat { get; set; }
    public string name { get; set; }
    public Firm_Group firm_group { get; set; }
    public string hash { get; set; }
    public string city_name { get; set; }
    public string address { get; set; }
    public string[] rubrics { get; set; }
    public int reviews_count { get; set; }
  }

  public class Firm_Group
  {
    public string id { get; set; }
    public object count { get; set; }
  }
}