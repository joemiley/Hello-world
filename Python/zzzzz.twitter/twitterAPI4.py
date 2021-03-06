import numpy as np
import tweepy
import requests
import base64
import stylecloud
import t

consumer_key = t.CONSUMER_KEY
consumer_secret = t.CONSUMER_SECRET

#Reformat the keys and encode them
key_secret = '{}:{}'.format(consumer_key, consumer_secret).encode('ascii')
#Transform from bytes to bytes that can be printed
b64_encoded_key = base64.b64encode(key_secret)
#Transform from bytes back into Unicode
b64_encoded_key = b64_encoded_key.decode('ascii')

base_url = 'https://api.twitter.com/'
auth_url = '{}oauth2/token'.format(base_url)
auth_headers = {
    'Authorization': 'Basic {}'.format(b64_encoded_key),
    'Content-Type': 'application/x-www-form-urlencoded;charset=UTF-8'
}
auth_data = {
    'grant_type': 'client_credentials'
}
auth_resp = requests.post(auth_url, headers=auth_headers, data=auth_data)
print(auth_resp.status_code)
access_token = auth_resp.json()['access_token']

trend_headers = {
    'Authorization': 'Bearer {}'.format(access_token)
}

trend_params = {
    'id': 23424975,
}

trend_url = 'https://api.twitter.com/1.1/trends/place.json'
trend_resp = requests.get(trend_url, headers=trend_headers, params=trend_params)

tweet_data = trend_resp.json()

trending_list = []
f = open("text2.txt", "w+")

for i in range(0, 40):
    print(tweet_data[0]['trends'][i]['name'])
    trending_list.append(tweet_data[0]['trends'][i]['name'])
    f.write(str(trending_list[i]) + "\r")
f.close()

word_cloud = stylecloud.gen_stylecloud(file_path='text2.txt',
                                       icon_name='fas fa-cloud',
                                       output_name='text_cloud2.png',
                                       #palette='colorbrewer.diverging.Spectral_11',
                                       gradient='horizontal',
                                       #background_color='#1A1A1A'
                                      )
