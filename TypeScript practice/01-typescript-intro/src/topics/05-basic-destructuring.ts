interface AudioPlayer{
    audioVolume: number;
    songDuration: number;
    song: string;
    details: Details;
}

interface Details{
    author: string;
    year: number;

}

const audioPlayer: AudioPlayer = {
    audioVolume: 100,
    songDuration: 2.39,
    song: "Si te hagarro con otro te mato",
    details: {
        author: 'Cacho Castaña',
        year: 1975
    }
}

const song = 'New Song';

const {song:anotherSong, songDuration:duration, details} = audioPlayer;
const {author} = details;

console.log('Song: ', anotherSong)
console.log('Duration: ', duration)
console.log('Author: ', author)

export{};