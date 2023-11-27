namespace PokeBattleSupport2.Model;

public class TypeResistanceModel
{
    /// <summary>
    /// 攻撃されたときの倍率
    /// </summary>
    public double EffectiveValue { get; set; }
    
    /// <summary>
    /// 耐性マークのテキスト
    /// </summary>
    public string Mark { get; set; } = string.Empty;

    /// <summary>
    /// 耐性マークの色
    /// </summary>
    public MudBlazor.Color MarkColor { get; set; }
}
