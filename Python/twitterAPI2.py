from tweepy.streaming import StreamListener
from tweepy import API
from tweepy import Cursor
from tweepy import OAuthHandler
from tweepy import Stream
# the .py we made
import t


class TwitterClient():
    # None defaults to your own timeline however if something is put in there then it will gab theirs
    def __init__(self, twitter_user=None):
        self.auth = TwitterAuthenticator().authenticate_twitter_app()
        self.twitter_client = API(self.auth)

        self.twitter_user = twitter_user

    #limits the number of tweets to show and interact with
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

# runs the program
if __name__ == "__main__":
    # variables
    hash_tag_list = ["donald trump", "hilary clinton", "barack obama", "bernie sanders"]
    fetched_tweets_filename = "tweets.json"

    # creating a twitter client object and takes a twitter username or just defaults to yours if empty
    # the bit after the @ symbol
    # if any tweets are pinned then its the first one under that
    twitter_client = TwitterClient("pycon")

    # this is where we specify how many tweets we want
    # you get none from this because you have no items on your timeline
    print(twitter_client.get_user_timeline_tweets(1))

    # methods and functions
    #twitter_streamer = TwitterStreamer()
    #twitter_streamer.stream_tweets(fetched_tweets_filename, hash_tag_list)





    # info on tweepy =    https: // docs.tweepy.org / en / latest / api.html


