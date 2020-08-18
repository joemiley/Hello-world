# api using = https://marketstack.com/quickstart
# api key = e04303c70f0d01ffe7be68bee05a0e04

# api end points
# End-of-Day Data: Get daily stock market data.
# Intraday Data: Get intraday and real-time market data.
# Tickers: Get information about stock ticker symbols.
# Exchanges: Get infotmation about all supported exchanges.
# Currencies: Get information about all supported currencies.
# Timezones: Get information about all supported timezones.

# api request start = http://api.marketstack.com/v1/eod?access_key=e04303c70f0d01ffe7be68bee05a0e04&symbols=AAPL

# access_key	[Required] Specify your API access key, available in your account dashboard.

# exchange	[Optional] To filter your results based on a specific stock exchange, use this parameter to specify the
# MIC identification of a stock exchange. Example: XNAS

# search	[Optional] Use this parameter to search stock tickers by name or ticker symbol.

# limit	[Optional] Specify a pagination limit (number of results per page) for your API request. Default limit value
# is 100, maximum allowed limit value is 1000.

# offset	[Optional] Specify a pagination offset value for your API request. Example: An offset value of 100 combined
# with a limit value of 10 would show results 100-110. Default value is 0, starting with the first available result.

from tkinter import *
import json
import requests

root = Tk()
root.title("Randombrooms Stock Market app")
root.geometry("650x425")

# apple stock market information
api_request_1 = requests.get("http://api.marketstack.com/v1/eod?access_key=e04303c70f0d01ffe7be68bee05a0e04&symbols=AAPL")
api_request_2 = requests.get("http://api.marketstack.com/v1/eod?access_key=e04303c70f0d01ffe7be68bee05a0e04&symbols=MSFT")

try:
    api_1 = json.loads(api_request_1.content)
    api_2 = json.loads(api_request_2.content)
except Exception as e:
    api_1 = "error . . ."
    api_2 = "error . . ."
for i in range(0, 20):
    apple_open = (api_1["data"][i]["open"])
    apple_date = (api_1["data"][i]["date"])
    mcs_open = (api_2["data"][i]["open"])
    open_label = Label(root, text="apples opening stock price was $" + str(apple_open) + " on the " + apple_date
                                  + "          where as microsoft stock was at $" + str(mcs_open))

    open_label.pack()


root.mainloop()

# all urls used:
# http://api.marketstack.com/v1/exchanges?access_key=e04303c70f0d01ffe7be68bee05a0e04
# http://api.marketstack.com/v1/eod?access_key=e04303c70f0d01ffe7be68bee05a0e04&symbols=AAPL
# http://api.marketstack.com/v1/eod?access_key=e04303c70f0d01ffe7be68bee05a0e04&symbols=MSFT
# https://www.google.com/search?q=symbols+on+nasdaq&oq=symbols+on+the+nas&aqs=chrome.1.69i57j0.6243j0j7&sourceid=chrome&ie=UTF-8
# https://status.marketstack.com/
# https://marketstack.com/documentation
