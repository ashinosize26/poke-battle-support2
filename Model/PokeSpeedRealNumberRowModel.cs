using PokeBattleSupport2.Shared;

namespace PokeBattleSupport2.Model;
public class PokeSpeedRealNumberRowModel
{
    /// <summary>
    /// ポケモンNo
    /// </summary>
    public long No { get; set; }

    /// <summary>
    /// 最速の実数値
    /// </summary>
    public int FastestSpeed { get; set; }

    /// <summary>
    /// 準速の実数値
    /// </summary>
    public int FastSpeed { get; set; }

    /// <summary>
    /// 無振の実数値
    /// </summary>
    public int DefaultSpeed { get; set; }

    /// <summary>
    /// 下降の実数値
    /// </summary>
    public int SlowSpeed { get; set; }

    /// <summary>
    /// 最遅の実数値
    /// </summary>
    public int SlowestSpeed { get; set; }

    /// <summary>
    /// 素早さランク
    /// </summary>
    public Common.SpeedRank SpeedRank { get; set; } = Common.SpeedRank.Unknown;
    }
