using GeekStore.Model.Components;

namespace GeekStore.Factory
{
    public static class CaseFactory
    {
        public static Case CreateCase()
        {
            return new Case(Case.FormFactorTypes.MidTower, "Corsair", "Graphite Series™ 760T");
        }

        public static Case CreateCase(Case.FormFactorTypes formFactor, string manufacturer, string model)
        {
            return new Case(formFactor, manufacturer, model);
        }
    }
}
