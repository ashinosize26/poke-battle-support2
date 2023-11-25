using PokeBattleSupport2.Shared;

namespace PokeBattleSupport2.Model;

/// <summary>
/// ポケモン
/// </summary>
public class PokeModel
{
    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// No
    /// </summary>
    public long No { get; set; }

    /// <summary>
    /// タイプ１
    /// </summary>
    public string Type1 { get; set; } = string.Empty;

    /// <summary>
    /// タイプ2
    /// </summary>
    public string Type2 { get; set; } = string.Empty;

    /// <summary>
    /// HP種族値
    /// </summary>
    public long H { get; set; }

    /// <summary>
    /// 攻撃種族値
    /// </summary>
    public long A { get; set; }

    /// <summary>
    /// 防御種族値
    /// </summary>
    public long B { get; set; }

    /// <summary>
    /// 特攻種族値
    /// </summary>
    public long C { get; set; }

    /// <summary>
    /// 特防種族値
    /// </summary>
    public long D { get; set; }

    /// <summary>
    /// 素早さ種族値
    /// </summary>
    public long S { get; set; }

    /// <summary>
    /// 合計種族値
    /// </summary>
    public long Total { get; set; }

    /// <summary>
    /// 素早さランク
    /// </summary>
    public Common.SpeedRank SpeedRank { get; set; } = Common.SpeedRank.Unknown;

    /// <summary>
    /// 持ち物
    /// </summary>
    public Common.BattleItem BattleItem { get; set; } = Common.BattleItem.None;
}