using PokeBattleSupport2.Shared;

namespace PokeBattleSupport2.Model;
public class PokeSpeedRealNumberRowModel
{
    public long No { get; set; }

    public int FastestSpeed { get; set; }

    public int FastSpeed { get; set; }

    public int DefaultSpeed { get; set; }

    public int SlowSpeed { get; set; }

    public int SlowestSpeed { get; set; }

    public Common.SpeedRank SpeedRank { get; set; } = Common.SpeedRank.Unknown;
    }
