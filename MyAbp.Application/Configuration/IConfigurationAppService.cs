using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbp.Configuration.Dto;

namespace MyAbp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}