namespace PokeBattleSupport2.Model;

/// <summary>
/// 対戦
/// </summary>
public class BattleModel
{
    /// <summary>
    /// 自分のパーティ
    /// </summary>
    public PokeModel[] MyParty { get; set; } = new PokeModel[6] { new (), new (), new (), new (), new (), new () };

    /// <summary>
    /// 相手のパーティ
    /// </summary>
    public PokeModel[] YourParty { get; set; } = new PokeModel[6] { new (), new (), new (), new (), new (), new () };
}