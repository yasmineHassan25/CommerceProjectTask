using AutoMapper;
using CommerceProject.Categories;
using CommerceProject.Products;

namespace CommerceProject;

public class CommerceProjectApplicationAutoMapperProfile : Profile
{
    public CommerceProjectApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        //mapping for UI : [Get]
        CreateMap<Product, ProductDTO>();

        /*map manually if properties not have same name.
        CreateMap<Product, ProductDTO>().ForMember(dest => dest.price, opt => opt.MapFrom(Src=>Src.price));*/

        //Mapping for editing in DB [post,put,delete]
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
