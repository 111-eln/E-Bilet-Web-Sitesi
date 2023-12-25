using eTicketApp.Models;

namespace eTicketApp.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();
                if (!context.Cinema.Any()) { 
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="cinema1",
                            Logo="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                            Description="asjdsjd dskndjkjs ksdnjdkj"
                        },
                         new Cinema()
                        { 
                            Name="cinema2",
                            Logo="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                            Description="asjd22sjd dskndjkjs ksdnjdkj"
                        },
                          new Cinema()
                        {
                            Name="cinema3",
                            Logo="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                            Description="as333jdsjd dskndjkjs ksdnjdkj"
                        },

                    });
                    context.SaveChanges();
                
                }
                if (!context.Producers.Any()) {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="producer1",
                            Bio="aaasss",
                            ProfilePictureURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                        },
                        new Producer()
                        {
                            FullName="producer2",
                            Bio="aaa22sss",
                            ProfilePictureURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                        },
                        new Producer()
                        {
                            FullName="producer3",
                            Bio="aaa33sss",
                            ProfilePictureURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                        },

                    });
                    context.SaveChanges();
                
                
                }
                if(context.Actors.Any()) {

                    context.Actors.AddRange(new List<Actor>()
                {
                    new Actor()
                    {
                        FullName="actor1",
                        Bio="asssjsjskjkj",
                        ProfilePictureURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg"
                    },
                     new Actor()
                    {
                        FullName="actor2",
                        Bio="ass2222sjsjskjkj",
                        ProfilePictureURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg"
                    },
                      new Actor()
                    {
                        FullName="actor3",
                        Bio="as333ssjsjskjkj",
                        ProfilePictureURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg"
                    },
                });
                    context.SaveChanges();
                }
                //if (!context.Movies.Any()) {
                //    context.AddRange(new List<Movie>()
                //    {
                //        new Movie()
                //        {
                //            Name="movie1",
                //            Description="aaaaaa111",
                //            price=100.1,
                //            imageURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg"
                //            ,
                //            StartDate=DateTime.Now,
                //            EndDate=DateTime.Today,
                //            MovieCategory=MovieCategory.Action,
                //        }, 
                //        new Movie()
                //        {
                //            Name="movie2",
                //            Description="aaaaaa222",
                //            price=170.1,
                //            imageURL="C:/Users/user/e-ticketProjesi/eTicketApp/eTicketApp/fotolar/02.jpg",
                //            StartDate=DateTime.Now,
                //            EndDate=DateTime.Today,
                //            MovieCategory=MovieCategory.Comedy,
                //        }

                //    });
                //    context.SaveChanges();
            }

            //if (!context.Actor_Movies.Any()) {
            //context.AddRange

            //}

        }


    }
    }

