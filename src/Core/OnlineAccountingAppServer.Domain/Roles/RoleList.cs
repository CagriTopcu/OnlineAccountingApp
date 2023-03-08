using OnlineAccountingAppServer.Domain.AppEntities.Identity;

namespace OnlineAccountingAppServer.Domain.Roles;

public sealed class RoleList
{
    public static List<AppRole> GetStaticRoles()
    {
        List<AppRole> appRoles = new()
        {
            #region UCAF
            new(code: UCAFCreateCode, title: UCAF, name: UCAFCreateName),
            new(code: UCAFUpdateCode, title: UCAF, name: UCAFUpdateName),
            new(code: UCAFRemoveCode, title: UCAF, name: UCAFRemoveName),
            new(code: UCAFReadCode,title: UCAF,name: UCAFReadName)
            #endregion
        };

        return appRoles;
    }

    #region RoleTitleNames
    public static string UCAF = "Hesap Planı";
    #endregion

    #region RoleCodeAndNAmes
    public static string UCAFCreateCode = "UCAF.Create";
    public static string UCAFCreateName = "Hesap Planı Kayıt";

    public static string UCAFUpdateCode = "UCAF.Update";
    public static string UCAFUpdateName = "Hesap Planı Güncelle";

    public static string UCAFRemoveCode = "UCAF.Remove";
    public static string UCAFRemoveName = "Hesap Planı Sil";

    public static string UCAFReadCode = "UCAF.Read";
    public static string UCAFReadName = "Hesap Planı Görüntüle";
    #endregion
}
