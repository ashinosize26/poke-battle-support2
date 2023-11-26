using PokeBattleSupport2.Model;
namespace PokeBattleSupport2.Shared;

public static class Common
{
    /// <summary>
    /// S種族値
    /// </summary>
    public enum SpeedRank
    {
        Fastest,
        Fast,
        Default,
        Slow,
        Slowest,
        Unknown
    }

    /// <summary>
    /// 持ち物
    /// </summary>
    public enum BattleItem
    {
        ChoiceScarf,
        None
    }

    /// <summary>
    /// 攻撃したときのタイプ相性による倍率の数値からマークを取得
    /// </summary>
    /// <param name="TypeEffectiveValue"></param>
    /// <returns></returns>
    public static TypeEffectiveMarkModel GetTypeEffectiveMark(double TypeEffectiveValue)
    {
        TypeEffectiveMarkModel mark = new();

        switch (TypeEffectiveValue)
        {
            case 4:
                mark.MarkText = "●4";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            case 2:
                mark.MarkText = "●";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            case 1:
                mark.MarkText = "";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            case 0.5:
                mark.MarkText = "▲";
                mark.MarkColor = MudBlazor.Color.Info;
                break;

            case 0.25:
                mark.MarkText = "▲1/4";
                mark.MarkColor = MudBlazor.Color.Info;
                break;

            case 0:
                mark.MarkText = "×";
                mark.MarkColor = MudBlazor.Color.Default;
                break;

            default:
                break;
        }

        return mark;
    }

    /// <summary>
    /// S実数値の計算
    /// </summary>
    /// <param name="baseStat"></param>
    /// <returns></returns>
    public static int CalcSpeedRealNumber(int baseStat, SpeedRank speedRank)
    {
        int realNumber = 0;
        if (baseStat == 0) return 0;

        switch (speedRank)
        {
            case SpeedRank.Fastest:
                // 最速
                realNumber = (int)Math.Floor((baseStat + 52) * 1.1);
                break;

            case SpeedRank.Fast:
                // 準速
                realNumber = baseStat + 52;
                break;

            case SpeedRank.Default:
                // 無振
                realNumber = baseStat + 20;
                break;

            case SpeedRank.Slow:
                // 下降
                realNumber = (int)Math.Floor((baseStat + 20) * 0.9);
                break;

            case SpeedRank.Slowest:
                // 最遅
                realNumber = (int)Math.Floor((baseStat + 5) * 0.9);
                break;
        }

        return realNumber;
    }
}
