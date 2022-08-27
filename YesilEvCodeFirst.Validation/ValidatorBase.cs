using System.Collections.Generic;

namespace YesilEvCodeFirst.Validation
{
    public abstract class ValidatorBase<TModel> where TModel : class
    {
        public TModel Model { get; set; }
        public List<string> ValidationMessages{ get; set; }
        public bool IsValid { get; set; } 
        public ValidatorBase(TModel model)
        {
            Model = model;
            ValidationMessages = new List<string>();
            IsValid = true;
            OnValidate();
        }

        public abstract void OnValidate();
    }
}
