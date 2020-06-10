using HYPJ.Applicatoin.Handler;
using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using HYPJ.Core.Structs;
using HYPJ.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HYPJ.Web.Core.Seed
{
    public class StarCloudDbSeed
    {
        public static void Init(IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var services = scope.ServiceProvider;

                var logFactory = services.GetRequiredService<ILoggerFactory>();
                var log = logFactory.CreateLogger("EFMigrate");

                var db = services.GetRequiredService<StarCloudDbContext>();
                var env = services.GetRequiredService<IHostingEnvironment>();

                var passwordHandle = services.GetRequiredService<IPasswordHandler>();

                if (db.Database.GetPendingMigrations().Any())
                {
                    log.LogInformation("开始执行数据库迁移...");

                    db.Database.Migrate();

                    log.LogInformation("数据库迁移完成");
                }
                log.LogInformation("开始添加初始数据...");
                //初始化角色
                InitializeRole(db, passwordHandle, env.IsDevelopment());
                //初始化模块
                InitializeMenu(db);

                log.LogInformation("添加初始数据完成");
            }

        }

        public static void InitializeMenu(StarCloudDbContext dbContext)
        {
            var dbMenu = dbContext.Set<Menu>();
            if (dbMenu.Any())
            {
                return;
            }
            var menus = new List<Menu>
            {
                new Menu
                {
                    Icon="Hui-iconfont-system",
                    Name="管理员管理",
                    ActionSref=ActionTypes.Group,
                    Path="1",
                    Children=new List<Menu>
                    {
                        new Menu
                        {
                            Name="管理员列表",
                            Icon="Hui-iconfont-system",
                            ActionSref="/SysOperator/list",
                            Path="11"
                        },
                        new Menu
                        {
                            Name = "角色权限",
                            Icon="Hui-iconfont-system",
                            ActionSref="/SysRole/list",
                            Path="11"
                        }
                    }
                },
                new Menu
                {
                    Name="栏目管理",
                    Icon="Hui-iconfont-fenlei",
                    ActionSref=ActionTypes.Group,
                    Path="1",
                    Children=new List<Menu>
                    {
                        new Menu
                        {
                            Name="酒店",
                            Icon="Hui-iconfont-fenlei",
                            ActionSref=ActionTypes.Action,
                            Path="11",
                            Children=new List<Menu>()
                        },
                        new Menu
                        {
                            Name="景点",
                            Icon="Hui-iconfont-fenlei",
                            ActionSref=ActionTypes.Action,
                            Path="11",
                            Children=new List<Menu>()
                        },
                        new Menu
                        {
                            Name="美食",
                            Icon="Hui-iconfont-fenlei",
                            ActionSref=ActionTypes.Action,
                            Path="11",
                            Children=new List<Menu>()
                        },
                        new Menu
                        {
                            Name = "商品分类",
                            Icon = "Hui-iconfont-fenlei",
                            Path="11",
                            ActionSref =ActionTypes.Action
                        }
                    }
                },
                new Menu
                {
                    Name = "客户中心",
                    Icon="Hui-iconfont-avatar2",
                    ActionSref=ActionTypes.Group,
                    Path="1",
                    Children=new List<Menu>
                    {
                        new Menu
                        {
                            Name = "微信用户管理",
                            Icon = "Hui-iconfont-fenlei",
                            ActionSref = ActionTypes.Action,
                            Path="11",
                        },
                        new Menu
                        {
                            Name = "评价管理",
                            Icon = "Hui-iconfont-fenlei",
                            ActionSref = ActionTypes.Action,
                            Path="11",
                        },
                        new Menu
                        {
                            Name="收藏管理",
                            Icon="Hui-iconfont-fenlei",
                            ActionSref = ActionTypes.Action,
                            Path="11",
                        }
                    }
                },
                new Menu
                {
                 Name = "商城设置",
                 Icon="Hui-iconfont-dianpu",
                 ActionSref=ActionTypes.Group,
                 Path="1",
                 Children=new List<Menu>
                 {
                     new Menu
                     {
                         Name="友情链接",
                         Icon="Hui-iconfont-fenlei",
                         ActionSref=ActionTypes.Action,
                         Path="11"
                     },
                     new Menu
                     {
                         Name="广告管理",
                         Icon="Hui-iconfont-fenlei",
                         ActionSref=ActionTypes.Action,
                         Path="11"
                     },
                     new Menu
                     {
                         Name="收藏管理",
                         Icon="Hui-iconfont-fenlei",
                         ActionSref=ActionTypes.Action,
                         Path="11"
                     },
                     new Menu
                     {
                         Name="基本设置",
                         Icon="Hui-iconfont-fenlei",
                         ActionSref=ActionTypes.Action,
                         Path="11"
                     },
                     new Menu
                     {
                        Name="投诉管理",
                        Icon="Hui-iconfont-fenlei",
                        ActionSref=ActionTypes.Action,
                        Path="11"
                     }
                 }
                },
                new Menu
                {
                    Name = "订单管理",
                    Icon="Hui-iconfont-order",
                    ActionSref=ActionTypes.Group,
                    Path="1",
                    Children = new List<Menu>
                        {
                            new Menu
                            {
                                Name = "订单处理",
                                Icon = "Hui-iconfont-feilei",
                                ActionSref = ActionTypes.Action,
                                Path="11",
                            },
                            new Menu
                            {
                                Name = "退款管理",
                                Icon = "Hui-iconfont-feilei",
                                ActionSref = ActionTypes.Action,
                                Path="11",
                            }
                    },
                },
                new Menu
                {
                    Name = "小程序手册",
                    Icon="Hui-iconfont-share-weixin",
                    Path="1",
                    ActionSref=ActionTypes.Group,
                    Children=new List<Menu>
                    {
                        new Menu
                        {
                            Name = "商城手册",
                            Icon = "Hui-iconfont-feilei",
                            Path="11",
                            ActionSref = ActionTypes.Action
                        }
                    }
                }
            };
            dbMenu.AddRange(menus);
            dbContext.SaveChanges();
        }
        private static void InitializeRole(StarCloudDbContext dbContext, IPasswordHandler passwordHandler, bool IsDevelopment)
        {
            var roleDbSet = dbContext.Set<Role>();
            if (roleDbSet.Any())
            {
                return;
            }
            if (!IsDevelopment)
            {
                (var salt, var encrypwd) = passwordHandler.GenerateEncryptPassword("admin*88");
                var roles = new List<Role>
                {
                   new Role
                   {
                        Name = "超级管理员",
                        IsSuperAdmin = true,
                        Description = "超级管理员",
                        AccountModels = new List<Account>()
                        {
                            new Account
                            {
                                UserName = "superadmin",
                                FullName = "superadmin",
                                Password=encrypwd,
                                Salt=salt,
                                Phone = "18988888888",
                                Avatar = "https://bgm-assets.oss-cn-shenzhen.aliyuncs.com/avatars/default-avatar.jpg",
                            }
                        },
                   },
                   new Role
                   {
                        Name = "销售经理",
                        IsSuperAdmin = false,
                        Description = "拥有部分权限",
                        AccountModels = new List<Account>()
                        {
                            new Account
                            {
                                UserName = "saleadmin",
                                FullName = "RoBo",
                                Password=encrypwd,
                                Salt=salt,
                                Phone = "1588888888",
                                Avatar = "https://bgm-assets.oss-cn-shenzhen.aliyuncs.com/avatars/default-avatar.jpg",
                            }
                        },
                   }
                };
                roleDbSet.AddRange(roles);
            }
            else
            {
                (var salt, var encrypwd) = passwordHandler.GenerateEncryptPassword("123456");

                var roles = new List<Role>
                {
                   new Role
                   {
                        Name = "超级管理员",
                        IsSuperAdmin = true,
                        Description = "最高级别,拥有所有权限!",
                        AccountModels = new List<Account>()
                        {
                            new Account
                            {
                                UserName = "admin123",
                                FullName = "黄总",
                                Password=encrypwd,
                                Salt=salt,
                                Phone = "18988888888",
                                Avatar = "https://bgm-assets.oss-cn-shenzhen.aliyuncs.com/avatars/default-avatar.jpg",
                            }
                        },
                   },
                   new Role
                   {
                        Name = "销售经理",
                        IsSuperAdmin = false,
                        Description = "拥有部分权限",
                        AccountModels = new List<Account>()
                        {
                            new Account
                            {
                                UserName = "test123",
                                FullName = "RoBo",
                                Password=encrypwd,
                                Salt=salt,
                                Phone = "1588888888",
                                Avatar = "https://bgm-assets.oss-cn-shenzhen.aliyuncs.com/avatars/default-avatar.jpg",
                            }
                        },
                   }
               };
                roleDbSet.AddRange(roles);
            }
            dbContext.SaveChanges();
        }


    }
}
