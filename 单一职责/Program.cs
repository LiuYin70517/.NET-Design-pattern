/*
 * 单一指责原则
 * 
 */

using Design_pattern;
using Design_pattern.Services;
using Microsoft.Extensions.DependencyInjection;

var service = new ServiceCollection();
service.AddScoped<TelPhone>();
service.AddScoped<IDial,Dial>();
service.AddScoped<IHangUp,HangUp>();
service.AddScoped<ISendMessage,SendMessageClass>();
service.AddScoped<IReceiveMessage,ReceiveMessageClass>();
using var sp = service.BuildServiceProvider();
var c = sp.GetRequiredService<TelPhone>();
c.DialPhoneNumber("13099999999");
c.SendMessage("hello");
c.HangUpNumber("13999999999");
c.ReceiveMessage("hello");
