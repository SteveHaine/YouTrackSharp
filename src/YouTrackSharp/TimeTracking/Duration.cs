using System;
using Newtonsoft.Json;

namespace YouTrackSharp.TimeTracking 
{
   /// <summary>
   /// A class that represents YouTrack duration information.
   /// </summary>
   //"duration": {
   //    "id": "120",
   //    "minutes": 120,
   //    "presentation": "2h",
   //    "$type": "DurationValue"
   //},
   public class Duration
   {
      /// <summary>
      /// Id of the duration.
      /// </summary>
      [JsonProperty("id")]
      public string Id { get; set; }

      /// <summary>
      /// total minutes.
      /// </summary>
      [JsonProperty("minutes")]
      public int Minutes { get; set; }

      /// <summary>
      /// textual presentation of the duration.
      /// </summary>
      [JsonProperty("presentation")]
      public string Presentation { get; set; }

      public TimeSpan TimeSpan => TimeSpan.FromMinutes(Minutes);

      public override string ToString()
      {
         return Presentation;
      }
   }
}
