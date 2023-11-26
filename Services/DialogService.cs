using CardManager.Models;
using Microsoft.AspNetCore.Components;

namespace CardManager.Services;

public class DialogService
{
    private readonly CardService _service;
    private readonly NavigationManager _navManager;
    public DialogService(CardService service, NavigationManager navManager)
    {
        _service = service;
        _navManager = navManager;
    }
    public bool ShowingDialog { get; set; }
    public Card Card { get; private set; } = new();
    public EDialogType Type { get; set; }

    public async Task ShowDialogAsync(EDialogType type, int id = 0)
    {
        Type = type;
        if (Type == EDialogType.Editar || Type == EDialogType.Excluir)
            Card = await _service.GetByIdAsync(id);

        ShowingDialog = true;
    }

    public void CloseDialog()
    {
        Type = EDialogType.None;
        ShowingDialog = false;
        _navManager.Refresh(true);
    }
}