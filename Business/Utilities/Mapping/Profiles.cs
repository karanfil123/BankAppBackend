using Business.Models.Request;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();

        CreateMap<User, UserUpdateDto>().ReverseMap();

        CreateMap<Accounts, AccountDto>().ReverseMap();
        CreateMap<Accounts, AccountCreateDto>().ReverseMap();
        CreateMap<AccountUpdateDto, Accounts>().ReverseMap();


        CreateMap<Transaction, TransactionDto>().ReverseMap();
        CreateMap<Transaction, TransactionUpdateDto>().ReverseMap();
        CreateMap<Transaction, TransactionCreateDto>().ReverseMap();


    }
}