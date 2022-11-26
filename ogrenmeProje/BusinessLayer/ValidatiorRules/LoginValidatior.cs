using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatiorRules
{
    public class LoginValidatior : AbstractValidator<KullaniciKayit>
    {
        public LoginValidatior()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen Mail Giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen Şifre Giriniz");
            RuleFor(x => x.Adres).NotEmpty().WithMessage("Lütfen Adres Giriniz.");
            RuleFor(x => x.FirmaAdi).NotEmpty().WithMessage("Lütfen FirmaAdi Giriniz");
            RuleFor(x => x.FirmaUnvan).NotEmpty().WithMessage("Lütfen FirmaUnvan Giriniz.");
            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Lütfen Telefon Giriniz");
            RuleFor(x => x.VergiDairesi).NotEmpty().WithMessage("Lütfen VergiDairesi Giriniz.");
            RuleFor(x => x.VergiNumarası).NotEmpty().WithMessage("Lütfen VergiNumarası Giriniz");
        }
    }
}
