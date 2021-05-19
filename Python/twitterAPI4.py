from tweepy.streaming import StreamListener
from tweepy import API
from tweepy import Cursor
from tweepy import OAuthHandler
from tweepy import Stream
import numpy as np
import pandas as pd
import json
import matplotlib.pyplot as plt
import stylecloud
import time
import sys
import keyboard

# the .py we made
import t


class TwitterClient():
    # None defaults to your own timeline however if something is put in there then it will gab theirs
    def __init__(self, twitter_user=None):
        self.auth = TwitterAuthenticator().authenticate_twitter_app()
        self.twitter_client = API(self.auth)

        self.twitter_user = twitter_user

    def get_twitter_client_api(self):
        return self.twitter_client

    # limits the number of tweets to show and interact with
    def get_user_timeline_tweets(self, num_tweets):
        tweets = []
        # items tells the thing how many items from your timeline you want
        # it saves them all in a list "tweets"
        for tweet in Cursor(self.twitter_client.user_timeline, id=self.twitter_user).items(num_tweets):
            tweets.append(tweet)
            return tweets

    def get_friend_list(self, num_friends):
        friend_list = []
        for friend in Cursor(self.twitter_client.friends, id=self.twitter_user).items(num_friends):
            friend_list.append(friend)
            return friend_list

    def get_home_timeline_tweets(self, num_tweets):
        home_timeline_tweets = []
        for tweet in Cursor(self.twitter_client.home_timeline, id=self.twitter_user).items(num_tweets):
            home_timeline_tweets.append(tweet)
            return home_timeline_tweets


# twitter authenticator
class TwitterAuthenticator():
    def authenticate_twitter_app(self):
        # holds the consumer keys
        auth = OAuthHandler(t.CONSUMER_KEY, t.CONSUMER_SECRET)
        # holds the access tokens
        auth.set_access_token(t.ACCESS_TOKEN, t.ACCESS_TOKEN_SECRET)
        return auth


class TwitterStreamer():
    def __init__(self):
        self.twitter_authenticator = TwitterAuthenticator()

    # this is where we are going to write our tweets to and authenticates
    def stream_tweets(self, fetched_tweets_filename, hash_tag_list):
        # calls the listener to start to create objects
        listener = TwitterListener(fetched_tweets_filename)

        auth = self.twitter_authenticator.authenticate_twitter_app()

        # uses all the credentials
        stream = Stream(auth, listener)

        # this is where we specify what we are looking for in list form
        stream.filter(track=hash_tag_list)


# creating a class of streamlistener objects
class TwitterListener(StreamListener):

    def __init__(self, fetched_tweets_filename):
        self.fetched_tweets_filename = fetched_tweets_filename

    # listens for the data and returns data and true
    def on_data(self, data):
        try:
            print(data)
            with open(self.fetched_tweets_filename, 'a') as tf:
                tf.write(data)
                return True
        except BaseException as e:
            print("error on data: "+ str(e))
            return True


    # happens if there is an error from the streamlistener
    def on_error(self, status):
        # this is an error code twitter gives you if your pulling too much to fast
        # they put you on timeout first time but eventually they will just block you
        # returning false kills it
        if status == 420:
            return False
        print(status)


class TweetAnalyser():
    # functionality for analyzing and catagorizing content from tweets
    def tweets_to_data_frame(self, tweets):
        df = pd.DataFrame(data=[tweet.text for tweet in tweets], columns=['Tweets'])

        # this creates a numpy array with the heading being each tweets tweet and id that its just
        # for looping through the tweets list
        # this is how we add new columns onto our table
        df['id'] = np.array([tweet.id for tweet in tweets])
        df['text'] = np.array([tweet.text for tweet in tweets])
        df['len'] = np.array([len(tweet.text) for tweet in tweets])
        df['date'] = np.array([tweet.created_at for tweet in tweets])
        df['source'] = np.array([tweet.source for tweet in tweets])
        df['likes'] = np.array([tweet.favorite_count for tweet in tweets])
        df['retweet count'] = np.array([tweet.retweet_count for tweet in tweets])
        return df


# runs the program
if __name__ == "__main__":
    timer_counter = 0

    while True:
        twitter_client = TwitterClient()
        tweets_analyzer = TweetAnalyser()

        api = twitter_client.get_twitter_client_api()

        #tweets = api.user_timeline(screen_name="boohoo", count=200)
        trends = api.trends_place(23424975)
        trends_string = json.dumps(trends)
        data = json.loads(trends_string)

        trending_list = []

        if timer_counter == 0 or timer_counter == 10:
            f10 = open("text10.txt", "w+")
            for i in range(0, 10):
                #print(trends[0]['trends'][i]['name'])
                trending_list.append(trends[0]['trends'][i]['name'])
                f10.write(str(trending_list[i]) + "\r")

            f10.close()

            word_cloud = stylecloud.gen_stylecloud(file_path='text10.txt',
                                                   icon_name='fas fa-cloud',
                                                   output_name='text_cloud10.png',
                                                   # palette='colorbrewer.diverging.Spectral_11',
                                                   # background_color='#1A1A1A',
                                                   gradient='horizontal')
            print("text10.txt and text_cloud10.png was created")

        if timer_counter == 0 or timer_counter == 30:
            f30 = open("text30.txt", "w+")
            for i in range(0, 30):
                #print(trends[0]['trends'][i]['name'])
                trending_list.append(trends[0]['trends'][i]['name'])
                f30.write(str(trending_list[i]) + "\r")

            f30.close()

            word_cloud = stylecloud.gen_stylecloud(file_path='text30.txt',
                                                   icon_name='fas fa-cloud',
                                                   output_name='text_cloud30.png',
                                                   # palette='colorbrewer.diverging.Spectral_11',
                                                   # background_color='#1A1A1A',
                                                   gradient='horizontal')
            print("text30.txt and text_cloud30.png was created")

        if timer_counter == 0 or timer_counter == 60:
            f60 = open("text60.txt", "w+")
            for i in range(0, 50):
                #print(trends[0]['trends'][i]['name'])
                trending_list.append(trends[0]['trends'][i]['name'])
                f60.write(str(trending_list[i]) + "\r")

            f60.close()

            word_cloud = stylecloud.gen_stylecloud(file_path='text60.txt',
                                                   icon_name='fas fa-cloud',
                                                   output_name='text_cloud50.png',
                                                   # palette='colorbrewer.diverging.Spectral_11',
                                                   # background_color='#1A1A1A',
                                                   gradient='horizontal')
            print("text60.txt and text_cloud50.png was created")

        print("timer in mins: " + str(timer_counter))
        time.sleep(60)
        timer_counter = timer_counter+1

        if timer_counter > 60:
            timer_counter = 1




    # df means data frame
    #df = tweets_analyzer.tweets_to_data_frame(tweets)


    # get the average length overall from the tweets
    #print(np.mean(df['len']))

    # get number of likes for the most liked tweet
    #print(np.max(df['likes']))

    # get the most retweets
    #print(np.max(df['retweet count']))

    # time series
    # time_likes = pd.Series(data=df['fav count'].values, index=df['date'])
    # time_likes.plot(figsize=(16, 4), color='red')
    # plt.show()

    # time_retweets = pd.Series(data=df['retweet count'].values, index=df['date'])
    # time_retweets.plot(figsize=(16, 4), color='red')
    # plt.show()

    #time_retweets = pd.Series(data=df['retweet count'].values, index=df['date'])
    #time_retweets.plot(figsize=(16, 4), color='red', label="retweets", legend=True)
    #time_fav_count = pd.Series(data=df['likes'].values, index=df['date'])
    #time_fav_count.plot(figsize=(16, 4), color='blue', label="likes", legend=True)
    #plt.show()


    # this command gives a list of attributes each tweet captured has that we can call in TweetAnalyser()
    # print(dir(tweets[0]))
    # prints the head of every tweet and the attribute we ask of it
    # print(df.head(10))
    # print(tweets[0].id)
    # print(tweets[0].retweet_count)
























    # info on tweepy =    https: // docs.tweepy.org / en / latest / api.html


