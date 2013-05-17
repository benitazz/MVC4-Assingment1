using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMusicSore.Models;

namespace MvcMusicSore.ViewModels
{
  public class StoreBrowseViewModel
  {
    public Genre Genre { get; set; }

    public List<Album> Albums { get; set; }
  }
}