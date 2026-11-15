using Aritiafel.Artifacts;
using System.Reflection;

namespace Aritiafel.Characters.Heroes
{
    //Allseer使用
    public static class Sophia
    {
        public static Action<string> SeeThroughAction { get; set; }
        public static Action<string> QuickSeeThroughAction { get; set; }
        static Sophia()
        {
            SetOutput(typeof(Console));
        }
        public static void SeeThrough(object o)
            => SeeThroughAction.Invoke(Allseer.SeeThrough(o));
        public static void QuickSeeThrough(object o)
            => QuickSeeThroughAction.Invoke(Allseer.SeeThrough(o));
        public static void SetOutput(object typeOrInstance)
        {
            if (typeOrInstance == null)
                throw new ArgumentNullException(nameof(typeOrInstance));
            if (!(typeOrInstance is Type type))
                type = typeOrInstance.GetType();
            SeeThroughAction = type.GetMethod("WriteLine", [typeof(string)])
                .CreateDelegate(typeof(Action<string>), type == typeOrInstance ? null : typeOrInstance) as Action<string>;
            QuickSeeThroughAction = type.GetMethod("Write", [typeof(string)])
                .CreateDelegate(typeof(Action<string>), type == typeOrInstance ? null : typeOrInstance) as Action<string>;
        }
    }
}
