class Album:
    def __init__(self, name, artist, songs) -> None:
        self.name = name
        self.artist = artist
        self.songs = songs
    def add_song(self, song):
        self.songs.append(song)
    def remove_song(self, song):
        self.songs.remove(song) 
    def __str__(self) -> str:
        return f"Album {self.name} by {self.artist}\nTracklist:\n{self.songs}"

class AlbumBrowser:
    """ Class for browsing the Albums database"""
    def search_album_by_artist(self, albums, artist):
        for album in albums:
            if album.artist == artist:
                return album
    
    
album1 = Album("AlbName1","Afraaz",["a","b","c"])
album2 = Album("AlbName2","DEF",["d","e","f"])
album3 = Album("AlbName3","GHI",["g","h"])
albumList = [album1,album2,album3]

albBrowser = AlbumBrowser()
print(albBrowser.search_album_by_artist(albumList,"Afraaz"))

        
