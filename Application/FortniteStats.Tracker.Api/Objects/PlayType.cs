using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FortniteStats.Tracker.Api.Objects
{
    public enum PlayType
    {
        Solo,
        Duo,
        Squad,
    }

    public class PlayTypeOriginal
    {
        public const string Solo = "p2";
        public const string Duo = "p10";
        public const string Squad = "p9";
    }

    public class PlayTypeMap : ReadOnlyDictionary<PlayType, string>
    {
        public PlayTypeMap(IDictionary<PlayType, string> dictionary)
            : base(dictionary)
        {
            dictionary.Add(PlayType.Solo, PlayTypeOriginal.Solo);
            dictionary.Add(PlayType.Duo, PlayTypeOriginal.Duo);
            dictionary.Add(PlayType.Squad, PlayTypeOriginal.Squad);
        }
    }
}
