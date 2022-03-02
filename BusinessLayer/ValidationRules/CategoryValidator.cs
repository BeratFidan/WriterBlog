using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı boş olamaz.");
            RuleFor(x=>x.CategoryDescription).NotEmpty().WithMessage("Açıklama boş olamaz.");
            RuleFor(x=>x.CategoryDescription).MinimumLength(5).WithMessage("Açıklama en az 5 karakter olmalıdır.");
            RuleFor(x=> x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı en az 3 karakter olmalıdır.");
            RuleFor(x=> x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı en fazla 20 karakter olmalıdır.");
        }
    }
}
