import { Component } from '@angular/core';
import { Bike } from 'src/app/models/bike';
import { ImagesService } from 'src/app/services/images.service';

@Component({
  selector: 'app-image-gallery',
  templateUrl: './image-gallery.component.html',
  styleUrls: ['./image-gallery.component.css']
})
export class ImageGalleryComponent {

  allImages: Bike[] = [];

  constructor(private imageService: ImagesService) {

    this.allImages = imageService.getImages();
    console.log("Todas las imagenes que me retorno el servicio previamente inyectado ");
    console.dir(this.allImages);

    console.log("Buscamos la imagen de id 6 ");
    console.dir(imageService.getImageById(6));
  }
}
