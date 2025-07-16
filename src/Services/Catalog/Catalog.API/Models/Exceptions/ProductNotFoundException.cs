namespace Catalog.API.Models.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException() :base("Product not found!") 
    {
    }
}
