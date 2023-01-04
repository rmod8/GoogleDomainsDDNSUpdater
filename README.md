# GoogleDomainsDDNSUpdater
A tool to automatically update a Google Domains Domain's Dynamic DNS.<br>
This allows for a domain to be constantly updated about the host PC's Public IP, useful for residential ISP connections.
<br>This tool is a unofficial continuation of [Saud's Google Domains Dynamic DNS Updater tool](https://github.com/saudiqbal/SaudsGoogleDomainsDynamicDNSUpdater).
<br>This program can only be used with a domain registered on [Google Domains](https://domains.google.com/registrar/).

![](https://cdn.discordapp.com/attachments/755457361472258069/1059966344214360106/GDDDNSUPreview1.png)

## How do i use it?
You need to create a new Dynamic DNS listing on the domain you want to use, which can be done in the 'DNS' tab of your domain.
Then you want to scroll to the very bottom, click on 'Show advanced settings.', then click 'Manage dynamic DNS'.
If you want to give it a subdomain, ie a UK server (uk.yourdomain.com) or a US server (us.yourdomain.com), you can but is not neccesary.
Leaving it blank will make it so only 'yourdomain.com' will be effected. If you just want to setup a simple domain, just leave the subdomain text
empty.<br>After that, click 'Save, then click on the 'Your domain has Dynamic DNS set up' drop-down box, then click the 'View Credentials' 
button next to the domain you want. Enter the Username and Password in the Google Domains DDNS Updater program.
<br><br>
### At this point you are done and you can click the 'Start' button to start the update cycle, but you have some configuration choices:
You can change the type of IP the DDNS is set to. Very important for different situations. If you're running a game server like Minecraft, be sure
to select IPv4, otherwise the IP the DDNS will be set to will be invalid.<br><br>
You can change the update interval, but i'd reccomend keeping it to 15 minutes to not spam the IP and DDNS API.<br><br>
You can enable 'Start Refresh when Open' to start the update interval when the program is opened. This can be tied with putting the program's
shortcut in 'AutoStart' to start the program after a system reboot.


## But why?
I wanted to host my own Google Domain, but because i have a Dynamic IP, i had to use some sort of DDNS updating tool.
I found Saud's one as it was the only one available for Windows. I saw the repository was closed so any issues or additions wouldn't be able to be done,
so i wanted to have a go at making a program like his, and maybe add some features.

## This one or Saud's one?
Personally, choose the one you like the most. If you have an issue with this program, please report it and i'll fix it as soon as possible.

## License & Warranty
This program is licensed under the MIT license, more can be read in the [LICENSE](https://github.com/rmod8/GoogleDomainsDDNSUpdater/blob/main/LICENSE.txt) file.

## Special Thanks
[Saud Iqbal](https://github.com/saudiqbal) - Creating the original program which served as the base for this program.<br>
[Mark James](http://www.famfamfam.com/about/) - Creator of Silk Icons, which is used in this program.<br>
ItsMeFlynn - Program Testing
