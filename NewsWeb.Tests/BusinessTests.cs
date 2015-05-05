using System;
using System.Threading.Tasks;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsWeb.ApplicationBuilder;
using NewsWeb.Business.Models;
using NewsWeb.Models;

namespace NewsWeb.Tests
{
    [TestClass]
    public class BusinessTests
    {
        [TestInitialize]
        public void Init()
        {
            ContainerManager.BuildContainer();
        }

        [TestMethod]
        public async Task InitializeDb()
        {
            var business = ContainerManager.Current.Resolve<ICategoryBusiness>();

            var category = new Category() {Id = Guid.NewGuid(), Name = "Sport"};
            var article1 = new Article();
            article1.Title = "Benji Marshall will come good says his teammate and Blues forward Trent Merrin";
            article1.Summary = "BENJI Marshall has been thrown in at the deep end at St George Illawarra but his brilliance will shine through in time.";
            article1.Content = @"That is the assessment of Dragons star Trent Merrin who says Marshall can help turn around the battling NRL club, who have won just one of their past seven games.
The Dragons have hit the wall after an impressive start to the year and while Marshall was never touted as the saviour, his first-up effort in the 36-0 capitulation to Parramatta has many wondering what he has to offer the joint venture.\n
But NSW back-rower Merrin is confident the former Wests Tigers superstar will come good.
“It was a struggle for him to come into a game like that in his first week at the club,” Merrin said.
“But I am excited for him, he is definitely going to have a point to prove and he has the skill and maturity to be able to do so.
“I'm sure there is a lot more of Benji to come.
“As soon as you starting building confidence and belief and get that mateship around you, it brings out the best in everyone.
“We will give him a few weeks to settle in at the club and make himself feel at home and then I think you will see the best in him.”
The Dragons have the bye this weekend, but despite the start of the State of Origin period the focus has not been taken off the future of coach Steve Price, with Blues mentor Laurie Daley linked to St George Illawarra this week.
Merrin said the players should be under pressure too.
“We have been all over the shop, we need to have a good look inside the club and take some ownership of what is going wrong,” he said.
“It is not the best place at the moment.
“But all the boys have faith in Steve, of course his is going to be under the pump, he is the coach of the team.
“They always look at the coach, when the team is going poor, there is some pressure there but we are all behind him.
“We have to get out of the slump we are in, step up and enjoy our footy.”";

            var article2 = new Article();
            article2.Title = "Manly star and Queensland utility Daly Cherry-Evans almost became a Canberra Raider";
            article2.Summary = "QUEENSLAND’S Daly Cherry-Evans is a Manly star but he came within the stroke of a pen from playing with the Canberra Raiders.";
            article2.Content = @"Brian Edwards, a former Raiders recruitment officer and current Broncos Logan Academy manager, said an 18-year-old Cherry-Evans almost signed with the Green Machine in 2007 after he was scouted playing with Wests colts in Brisbane.
                               “There wasn’t any interest in Daly and I watched him over the course of a few games and he improved quickly each game,’’ Edwards said.
“I thought in that year he could step up and already steer a Queensland Cup side around the park.’’
Edwards talked with Cherry-Evans’ father Troy about his son playing for Canberra.
But the Raiders already had Todd Carney and Terry Campese, and Cherry-Evans would have had to have served an apprenticeship behind the pair.
In the meantime Manly’s former recruitment ace Noel Cleal entered the fray, signing him from under Canberra’s nose.
The near miss proved to be costly for Canberra because Carney was sacked by the club in 2008 after a string of off-field incidents.
Easts coach Craig Ingebrigtsen, who also coached Cherry-Evans as a junior at Redcliffe, said he was also missed by the Broncos and Queensland Cup clubs.
“Daly was by far the best in the competition but the Broncos didn’t recognise it and both Norths and Redcliffe said he didn’t fit what they needed and that his foot speed was a concern,” Ingebrigtsen said.
Ingebrigtsen said Cherry-Evans was one of the three best players he had brought through the system alongside Broncos utility Matt Gillett and new Storm recruit Cody Walker.
“He was so composed in everything he did and worked harder on his game than anyone I know,” he said.";
            category.Articles.Add(article1);
            category.Articles.Add(article2);
            await business.AddCategoryAsync(category);

            category = new Category() { Id = Guid.NewGuid(), Name = "Finance" };
            var f_article1 = new Article();
            f_article1.Title = "Stocks to watch at the close on Thursday";
            f_article1.Summary = "WPL FMG JHX CTX";
            f_article1.Content = @"STOCKS to watch on the Australian stock exchange at the close on Thursday:
WPL - WOODSIDE PETROLEUM - up 49 cents, or 1.19 per cent, at $41.72
Woodside Petroleum chief executive Peter Coleman will discuss capital management issues with his board following the company's exit from the Leviathan gas project.
FMG - FORTESCUE METALS - up 16 cents, or 3.61 per cent, at $4.59
Fortescue Metals has threatened to stand down workers if a threatened tugboat deckhand strike at Port Hedland goes ahead.
JHX - JAMES HARDIE - up 78 cents, or 5.7 per cent, at $14.47
Building products maker James Hardie has more than doubled annual profit as sales grew in its key markets of Australia, Europe and the United States.
CTX - CALTEX AUSTRALIA - up 40 cents, or 1.8 per cent, at $22.30
Caltex Australia will sell four petrol stations to win approval for its $95 million takeover of petrol retailer and distributor Scott's Group.";

            var f_article2 = new Article();
            f_article2.Title = "NZ shares snap five-day slide";
            f_article2.Summary = "NEW Zealand shares have advanced after a five-day slide gave investors confidence to buy companies offering dependable returns, including some in the property sector.";
            f_article2.Content = @"The NZX 50 Index rose 20.267 points, or 0.4 per cent, to 5128.840 on Thursday.
Within the index, 28 shares rose, 13 fell and nine were unchanged. Turnover was $143 million.
Volatility in US markets in recent months, particularly in high growth and tech stocks where investors have questioned high valuations relative to earnings, has led to greater risk aversion in equity markets, said Grant Williamson, director at Hamilton Hindin Greene.
That has caused some investors to re-think things and put a higher portion of their funds in more conservative assets.
Gains included Argosy Property up 1.1 per cent to 96.5 cents, Precinct Properties one per cent to $1.055, Goodman Property Trust 0.5 per cent to $1.05 and Kiwi Income Trust 0.4 per cent to $1.165.
We have seen investors take a little bit more of a conservative stance in the last couple of weeks and we are now starting to see the property trusts come back into focus, they had been underperforming for a number of months Mr Williamson said.
But most of them have reported pretty good results in recent days.
Steel & Tube Holdings led the index higher, up 4.1 per cent to $3.08. Air New Zealand rose 1.6 per cent to $2.17, while Fletcher Building advanced 1.4 per cent to $9.17.
Chorus fell 2.3 per cent to $1.71 after the Commerce Commission extended the deadline for its final decision on the telecommunications network operator's copper pricing.
The share price was just starting to gain some traction from presentations that the company was making but that was all shot down following this morning's announcement that there is going to be a longer time for the determination, Mr Williamson said.";

            category.Articles.Add(f_article1);
            category.Articles.Add(f_article2);
            await business.AddCategoryAsync(category);
        }

        [TestMethod]
        public async Task TestCategories()
        {
            var business = ContainerManager.Current.Resolve<ICategoryBusiness>();
            var categories = await business.GetAllAsync();

            Assert.IsNotNull(categories);
            Assert.AreEqual(2, categories.Count);
        }
    }
}
