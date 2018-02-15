using Discord;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using NadekoBot.Core.Services;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;
using NadekoBot.Extensions;
using System.IO;
using AngleSharp;
using AngleSharp.Dom.Html;
using AngleSharp.Dom;
using Configuration = AngleSharp.Configuration;
using Discord.Commands;
using ImageSharp;
using NadekoBot.Common;
using NadekoBot.Common.Attributes;
using NadekoBot.Modules.Searches.Common;
using NadekoBot.Modules.Searches.Services;
using NadekoBot.Common.Replacements;
using Discord.WebSocket;
using NadekoBot.Core.Modules.Searches.Common;

namespace Nadeko.Modules.Misc
{
    //IDK DISCORD API PLS HALP QAQ
    public class Misc : ModuleBase<SocketCommandContext>
    {
        //[Command("greet")]
        public async Task Greeting()
        {

            if (Context.Message.Channel.Id == 410540798103519243) 
            {
                try 
                {
                    if (Context.Message.Content.ToLower().StartsWith("agree"))
                    {
                        var author = Context.User as SocketGuildUser;
                        await author.AddRoleAsync(author.Guild.Roles.First(r => r.Name == "Good Egg"));
                        await author.RemoveRoleAsync(author.Guild.Roles.First(r => r.Name == " Bad Egg"));
                        author.Guild.TextChannels.First(c => c.Id == 411989361509531658).SendMessageAsync($"Hey<@${author.Id}>, welcome to **{author.Guild.Name}**!");
                        await Context.Message.DeleteAsync();
                    } 
                        else 
                        {
                            await Context.Message.DeleteAsync();
                        }
                } 
                        catch(Exception e) 
                        {
                            Console.WriteLine(e);
                        }
            }
        }
    }
}