using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DemoTrigger{


    public static List<DemoArticle> listOfArticles = new List<DemoArticle>();


    public static void TriggerArticleDownload(){
        foreach (DemoArticle article in listOfArticles){
            article.FetchModel();
        }

    }


    public static void AddToList(DemoArticle article){
        listOfArticles.Add(article);
    }

    public static void ResetList(){
        listOfArticles = new List<DemoArticle>();
    }


}
