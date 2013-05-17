using System.Collections.Generic;

namespace MvcMusicSore.ViewModels
{
  public class StoreIndexViewModel
  {
    public int NumberOfGenres { get; set; }

    public List<string> Genres { get; set; }
  }
}