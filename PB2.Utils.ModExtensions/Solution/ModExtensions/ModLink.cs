using PhantomBrigade.Mods;

namespace ModExtensions
{
    public class ModLinkCustom : ModLink
    {
        public override void OnLoadStart()
        {
            UnityEngine.Debug.Log ("ModExtensions | OnLoadStart");
        }
    }
}