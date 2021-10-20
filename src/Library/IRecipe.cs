using System;

namespace Full_GRASP_And_SOLID
{
    public interface IRecipe
    {
        void RemoveStep(BaseStep step);
        public string GetTextToPrint();
    }
}

