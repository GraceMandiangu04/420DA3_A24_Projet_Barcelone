using _420DA3_A24_Projet.Business.Domain.Pivots;

namespace _420DA3_A24_Projet.Business.Domain.Utils;

internal enum ShippingOrderProductModificationTypeEnum {
    Addition,
    Modification,
    Removal
}

internal class ShippingOrderProductModification {

    public ShippingOrderProduct ShippingOrderProduct { get; set; }
    public ShippingOrderProductModificationTypeEnum ModificationType { get; set; }
    public int OriginalQuantity { get; set; }
    public int NewQuantity { get; set; }

    public ShippingOrderProductModification(ShippingOrderProduct shippingOrderProduct, ShippingOrderProductModificationTypeEnum modificationType) {
        this.ShippingOrderProduct = shippingOrderProduct;
        this.ModificationType = modificationType;
    }

}
