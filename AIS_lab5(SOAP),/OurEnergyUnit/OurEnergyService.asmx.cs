using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OurEnergyUnit
{
    /// <summary>
    /// Сводное описание для OurEnergyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class OurEnergyService : System.Web.Services.WebService
    {       
        public enum Energys
        {
            joule,
            kilojoule,
            megajoule,
            gigajoule,
            calorie,
            watthour,
            electronvolt,
            footpound
        }       

        [WebMethod]
        public double ChangeEnergyUnit(double value, Energys from, Energys to)
        {
            double result = 0;
            switch(from)
            {
                #region joule
                case Energys.joule:
                    {
                        switch(to)
                        {
                            case Energys.joule:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = 0.001 * value;
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result =value * Math.Pow(10, -6);
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * Math.Pow(10, -9);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 0.2388458966275;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 0.00027777777777778;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 6.241509647120 * Math.Pow(10,18);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 0.73756214927727;
                                    return result;
                                }
                            default: return result;
                        }                                 
                    }
                #endregion
                #region kilojoule
                case Energys.kilojoule:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * 1000;
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value * Math.Pow(10, -3);
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * Math.Pow(10, -6);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 238.8458966275;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 0.27777777777778;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 6.2415096471204 * Math.Pow(10, 21);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 737.56214927727;
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                #region megajoule
                case Energys.megajoule:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * Math.Pow(10, 6);
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value * Math.Pow(10, 3);
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * Math.Pow(10, -3);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 238845.8966275;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 277.77777777778;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 6.2415096471204 * Math.Pow(10, 24);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 737562.14927727;
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                #region gigajoule
                case Energys.gigajoule:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * Math.Pow(10, 9);
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value * Math.Pow(10, 6);
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value * Math.Pow(10, 3);
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 238845896.6275;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 277777.77777778;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 6.2415096471204 * Math.Pow(10, 27);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 737562149.27727;
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                #region calorie
                case Energys.calorie:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * 4.1868;
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value * 0.0041868;
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value * 4.1868 * Math.Pow(10,-6);
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * 4.1868 * Math.Pow(10, -9);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 0.001163;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 2.6131952590564 * Math.Pow(10, 19);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 3.0880252065941;
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                #region watthour
                case Energys.watthour:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * 3600;
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value * 3.6;
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value * 0.0036;
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * 3.6 * Math.Pow(10, -6);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 859.84522785899;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 2.2469434729634 * Math.Pow(10, 22);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 2655.2237373982;
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                #region electronvolt
                case Energys.electronvolt:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * 1.602176487 * Math.Pow(10, -19);
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value * 1.602176487 * Math.Pow(10, -22);
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value * 1.602176487 * Math.Pow(10, -25);
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * 1.602176487 * Math.Pow(10, -28);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 3.8267327959301 * Math.Pow(10, -20);
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 4.4504902416667 * Math.Pow(10, -23);
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value;
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value * 1.1817047332732 * Math.Pow(10, -19);
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                #region footpound
                case Energys.footpound:
                    {
                        switch (to)
                        {
                            case Energys.joule:
                                {
                                    result = value * 1.3558179483314;
                                    return result;
                                }
                            case Energys.kilojoule:
                                {
                                    result = value * 0.0013558179483314;
                                    return result;
                                }
                            case Energys.megajoule:
                                {
                                    result = value * 1.3558179483314 * Math.Pow(10, -6);
                                    return result;
                                }
                            case Energys.gigajoule:
                                {
                                    result = value * 1.3558179483314 * Math.Pow(10, -9);
                                    return result;
                                }
                            case Energys.calorie:
                                {
                                    result = value * 0.32383155353287;
                                    return result;
                                }
                            case Energys.watthour:
                                {
                                    result = value * 0.00037661609675872;
                                    return result;
                                }
                            case Energys.electronvolt:
                                {
                                    result = value * 8.4623508042494 * Math.Pow(10, 18);
                                    return result;
                                }
                            case Energys.footpound:
                                {
                                    result = value;
                                    return result;
                                }
                            default: return result;
                        }
                    }
                #endregion
                default: return result;
            }            
        }
    }
}
