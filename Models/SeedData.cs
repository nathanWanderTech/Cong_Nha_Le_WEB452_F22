
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web452Assignment1.Data;
using System;
using System.Linq;
using System.Drawing;
using System.ComponentModel.Design;

namespace Web452Assignment1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Web452Assignment1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Web452Assignment1Context>>()))
            {
                // Look for any movies.
                if (context.Bed.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bed.AddRange(
                    new Bed
                    {
                        Name = "Sally",
                        Image = "https://images.unsplash.com/photo-1505693416388-ac5ce068fe85?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8YmVkfGVufDB8fDB8fA%3D%3D&w=1000&q=80",
                        Price = 189,
                        Type = "Normal",
                        Color = "White",
                        Size = "Queen",
                        Designer = "Alexander",
                        CustomerReview = 5
                    },
                    new Bed
                    {
                        Name = "Harry",
                        Image = "https://images.unsplash.com/photo-1588046130717-0eb0c9a3ba15?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MzF8fGJlZHxlbnwwfHwwfHw%3D&w=1000&q=80",
                        Price = 200,
                        Type = "Normal",
                        Color = "White",
                        Size = "Queen",
                        Designer = "Alexander",
                        CustomerReview = 3
                    },
                    new Bed
                    {
                        Name = "Princess",
                        Image = "https://media.gettyimages.com/photos/pink-bedroom-interior-picture-id1134352503?s=612x612",
                        Price = 452,
                        Type = "Normal",
                        Color = "Pink",
                        Size = "Queen",
                        Designer = "Leo Pat",
                        CustomerReview = 2
                    },
                    new Bed
                    {
                        Name = "Star wars",
                        Image = "https://www.ebeddingsets.com/wp-content/uploads/2018/05/Star-Wars-The-Last-Jedi-Comforter-Set1.jpg",
                        Price = 99,
                        Type = "Normal",
                        Color = "Red",
                        Size = "Single",
                        Designer = "Lucas",
                        CustomerReview = 5
                    },
                    new Bed
                    {
                        Name = "Pretty Princess",
                        Image = "https://i.pinimg.com/736x/78/39/fd/7839fd4bc2f3e131aa985f105232b14d.jpg",
                        Price = 345,
                        Type = "Normal",
                        Color = "White and Pink",
                        Size = "Single",
                        Designer = "Disney",
                        CustomerReview = 3
                    },
                    new Bed
                    {
                        Name = "Digimon adventure",
                        Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbMH_WHaDvdeh5HbRoeV_m8zGTz5P9dB0pww&usqp=CAU",
                        Price = 500,
                        Type = "Normal",
                        Color = "Wood",
                        Size = "Single",
                        Designer = "Otaku",
                        CustomerReview = 4
                    },
                    new Bed
                    {
                        Name = "Girly bunk bed",
                        Image = "https://media.istockphoto.com/photos/childrens-room-picture-id1366856874?b=1&k=20&m=1366856874&s=170667a&w=0&h=ktQnyfHf1Sa0aHR0ErgPltGOCmHU2r9GJiEF0gRvQR0=",
                        Price = 149,
                        Type = "Bunk bed",
                        Color = "Lotus pink",
                        Size = "Single",
                        Designer = "Your designer",
                        CustomerReview = 4
                    },
                    new Bed
                    {
                        Name = "Vinking bed",
                        Image = "https://img-new.cgtrader.com/items/274696/0fd350161f/large/bed-viking-style-3d-model.jpg",
                        Price = 849,
                        Type = "Normal",
                        Color = "Brown",
                        Size = "Single",
                        Designer = "Viking",
                        CustomerReview = 5
                    },
                    new Bed
                    {
                        Name = "Modern Japanese bed",
                        Image = "https://www.thefutonshop.com/media/wysiwyg/Categories/japanese-furniture/tatami-bed-honey-oak.png",
                        Price = 999,
                        Type = "Normal",
                        Color = "Dark brown",
                        Size = "Queen",
                        Designer = "Kimochi",
                        CustomerReview = 5
                    },
                    new Bed
                    {
                        Name = "Royal",
                        Image = "https://ae01.alicdn.com/kf/Hb1aeddb1b2d444fd9063603152c7300aV/High-quality-European-modern-leather-french-bed-2-people-king-size-Luxury-gold-color-p10076.jpg_Q90.jpg_.webp",
                        Price = 5665,
                        Type = "Normal",
                        Color = "Gold",
                        Size = "King",
                        Designer = "Louis",
                        CustomerReview = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

