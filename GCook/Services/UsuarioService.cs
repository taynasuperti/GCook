using GCook.Data;
using GCook.Helpers;
using GCook.Models;
using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCook.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;
    private readonly SignInManager<Usuario> _signInManager;
    private readonly UserManager<Usuario> _userManager;

    public UsuarioService(
        AppDbContext context, 
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager
    )
    {
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
    }


    public async Task<SignInResult> LoginUsuario(LoginVM login)
    {
        string userName = login.Email;
        if (Helper.IsValidEmail(login.Email))
        {
            var user = await _userManager.FindByEmailAsync(login.Email);
            if (user != null)
                userName = user.UserName;
        }

        var result = await _signInManager.PasswordSignInAsync(
            userName, login.Senha, login.Lembrar, lockoutOnFailure: true
        );
    }

    public Task LogoutUsuario()
    {
        throw new NotImplementedException();
    }
}
