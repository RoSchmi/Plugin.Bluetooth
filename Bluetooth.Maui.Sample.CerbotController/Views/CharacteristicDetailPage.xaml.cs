using Bluetooth.Abstractions.Scanning;
using Bluetooth.Maui.Sample.CerbotController.Infrastructure;
using Bluetooth.Maui.Sample.CerbotController.ViewModels;

namespace Bluetooth.Maui.Sample.CerbotController.Views;

/// <summary>
///     Page for detailed characteristic interactions (read/write/notify).
/// </summary>
public partial class CharacteristicDetailPage : BaseContentPage<CharacteristicDetailViewModel>, IQueryAttributable
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CharacteristicDetailPage" /> class.
    /// </summary>
    public CharacteristicDetailPage(CharacteristicDetailViewModel viewModel) : base(viewModel)
    {
        InitializeComponent();
    }

    /// <summary>
    ///     Applies query attributes (navigation parameters) to the page.
    /// </summary>
    /// <param name="query">The query parameters.</param>
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // Get the characteristic from navigation parameters
        if (query.TryGetValue("Characteristic", out var characteristicObj) &&
            characteristicObj is IBluetoothRemoteCharacteristic characteristic)
        {
            ViewModel.SetCharacteristic(characteristic);
        }
    }
}
