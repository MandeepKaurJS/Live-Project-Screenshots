
# Download IMDB's Top 250 data
url = 'http://www.imdb.com/chart/top'
response = requests.get(url)
soup = BeautifulSoup(response.text, 'lxml')
#Get all necessary information from the IMDb webpage (title, link, cast)
#movies = soup.select('td.titleColumn')
#rating=soup.select('td.ratingColunm imdbRating')
movies = soup.find_all('table',class_='chart full-width')
#creating list to store movie titles


def topfive(request):
	
	imdb = []
	poster = []
	ratings = []
	watchinglist = []
	for container in movies[:5]:
		# title
		title = container.find_all('td', class_='titleColumn')
		for title in title[:5]:
			title2=title.get_text()
			watchinglist.append(title2)

		# poster or image
		poster_col = container.td.a.img['src']
		# ratings
		rating = container.find_all('td', class_='ratingColumn imdbRating')
		for title in rating[:5]:
			title2=title.get_text()
			ratings.append(title2)
		imdb.append(poster_col)