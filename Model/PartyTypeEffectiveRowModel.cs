namespace PokeBattleSupport2.Model;
public class PartyTypeEffectiveRowModel
{
    /// <summary>
    /// タイプ名
    /// </summary>
    public string TypeName { get; set; } = string.Empty;
    
    /// <summary>
    /// パーティのポケモンの耐性
    /// </summary>
    public TypeResistanceModel[] Marks { get; set; } = new TypeResistanceModel[6] { new(), new(), new(), new(), new(), new() };

    /// <summary>
    /// 一貫
    /// </summary>
    public bool Consistent { get; set; }
}
