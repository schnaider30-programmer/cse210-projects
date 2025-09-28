using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video firstVideo = new Video();
        Video secondVideo = new Video();
        Video thirdVideo = new Video();
        Video fourthVideo = new Video();

        firstVideo._author = "Temple Insight";
        firstVideo._title = "Exploring the Salt Lake Temple Renovation";
        firstVideo._lengthInSecond = 420;

        secondVideo._author = "History Vault";
        secondVideo._title = "Top 5 Facts About the Nauvoo Temple";
        secondVideo._lengthInSecond = 315;

        thirdVideo._author = "Sacred Spaces";
        thirdVideo._title = "Paris France Temple: Architecture and Symbolism";
        thirdVideo._lengthInSecond = 260;

        fourthVideo._author = "Utah Faith Stories";
        fourthVideo._title = "Why the Cedar City Temple Matters to Locals";
        fourthVideo._lengthInSecond = 390;

        Comment c1 = new Comment();
        c1.AddAuthorOfComment("Amina");
        c1.AddCommentText("I love the quality of this video—very well edited!");

        Comment c2 = new Comment();
        c2.AddAuthorOfComment("Carlos");
        c2.AddCommentText("Super informative, thanks for sharing.");

        Comment c3 = new Comment();
        c3.AddAuthorOfComment("Fatou");
        c3.AddCommentText("I didn’t know about this product, great discovery!");

        Comment c4 = new Comment();
        c4.AddAuthorOfComment("Leo");
        c4.AddCommentText("The background music is too loud, hard to focus.");

        Comment c5 = new Comment();
        c5.AddAuthorOfComment("Sophie");
        c5.AddCommentText("Excellent work, keep it up!");

        Comment c6 = new Comment();
        c6.AddAuthorOfComment("Jules");
        c6.AddCommentText("Could you make a video about the next model?");

        Comment c7 = new Comment();
        c7.AddAuthorOfComment("Nadia");
        c7.AddCommentText("I shared this with my coworkers—really helpful.");

        Comment c8 = new Comment();
        c8.AddAuthorOfComment("Marc");
        c8.AddCommentText("Smooth editing, props to the video team.");

        Comment c9 = new Comment();
        c9.AddAuthorOfComment("Chantal");
        c9.AddCommentText("I think the pacing is a bit too fast.");

        Comment c10 = new Comment();
        c10.AddAuthorOfComment("Ravi");
        c10.AddCommentText("Thanks for the clear and precise explanations.");

        Comment c11 = new Comment();
        c11.AddAuthorOfComment("Elena");
        c11.AddCommentText("Loved the part about hidden features!");

        Comment c12 = new Comment();
        c12.AddAuthorOfComment("Thomas");
        c12.AddCommentText("Can you add subtitles in English next time?");

        Comment c13 = new Comment();
        c13.AddAuthorOfComment("Grace");
        c13.AddCommentText("This product looks super practical—I’ll try it.");

        Comment c14 = new Comment();
        c14.AddAuthorOfComment("Yann");
        c14.AddCommentText("You could improve the audio quality, but great job.");

        Comment c15 = new Comment();
        c15.AddAuthorOfComment("Maya");
        c15.AddCommentText("Very well structured video, easy to follow.");

        Comment c16 = new Comment();
        c16.AddAuthorOfComment("Noah");
        c16.AddCommentText("I learned so much—thank you!");

        firstVideo.ListOfComment(c1);
        firstVideo.ListOfComment(c4);
        firstVideo.ListOfComment(c13);
        firstVideo.ListOfComment(c10);

        secondVideo.ListOfComment(c2);
        secondVideo.ListOfComment(c12);
        secondVideo.ListOfComment(c11);
        secondVideo.ListOfComment(c3);
        secondVideo.ListOfComment(c1);

        thirdVideo.ListOfComment(c5);
        thirdVideo.ListOfComment(c14);
        thirdVideo.ListOfComment(c16);
        thirdVideo.ListOfComment(c8);
        thirdVideo.ListOfComment(c2);
        thirdVideo.ListOfComment(c4);

        fourthVideo.ListOfComment(c9);
        fourthVideo.ListOfComment(c7);
        fourthVideo.ListOfComment(c6);
        fourthVideo.ListOfComment(c10);

        _videos.Add(firstVideo);
        _videos.Add(secondVideo);
        _videos.Add(thirdVideo);
        _videos.Add(fourthVideo);



        for (int i = 0; i < _videos.Count(); i++)
        {
            Console.WriteLine($"{i + 1}.Video Title: {_videos[i]._title}");
            Console.WriteLine($"{i + 1}.Author: {_videos[i]._author}");
            Console.WriteLine($"{i + 1}.Length: {_videos[i]._lengthInSecond}");
            Console.WriteLine($"Number of Comments: {_videos[i].GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            Console.WriteLine(_videos[i].GetAllCommentsText().Trim('"'));
        }
    }
}