using AutoMapper;
using ProductShop.DTOs.Category;
using ProductShop.DTOs.CategoryProduct;
using ProductShop.DTOs.Product;
using ProductShop.DTOs.User;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            this.CreateMap<ImportUserDto, User>();
            this.CreateMap<ImportProductDto,Product>();
            this.CreateMap<ImportCategoryDto,Category>();
            this.CreateMap<ImportCategoryProductDto,CategoryProduct>();

            this.CreateMap<Product, ExportProductsInRangeDto>()
                .ForMember(d => d.SellerFullName, 
                           mo => mo.MapFrom(s => 
                           $"{s.Seller.FirstName} {s.Seller.LastName}"));


            this.CreateMap<Product, ExportSoldProductShortInfoDto>();

        }
    }
}
