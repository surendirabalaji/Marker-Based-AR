# AR Movie Title Cards - Unity AR Core & Vuforia

## Project Overview

This augmented reality (AR) project uses **Unity AR Core** and **Vuforia** to create an engaging AR experience where scanning movie title cards triggers the playback of corresponding movie trailers or videos. It is a **marker-based AR** system that allows users to view videos simply by pointing their device camera at a specific movie title card, creating an interactive and immersive experience.

## Features

### 1. Marker-Based Video Playback
- **Marker Recognition:** The project employs **marker-based tracking** using Vuforia to recognize predefined movie title cards. Each card acts as an AR marker that triggers specific content.
- **Video Playback:** Once a title card is recognized, a corresponding video, such as the movie trailer, starts playing in AR. The video appears to be projected onto the card, creating a visually immersive effect.

### 2. Unity AR Core Integration
- **AR Core for Stability:** Unity AR Core is used to enhance the tracking quality and ensure smooth and stable video playback, making the AR experience enjoyable and consistent.
- **3D Video Overlay:** Videos are overlaid in 3D space, appearing to play directly on top of the movie title card, providing an interactive and cinematic experience for the user.

### 3. Vuforia Integration
- **Image Target Database:** Vuforia's Image Target feature was used to create a database of movie title cards. Each card was added as a unique target, and corresponding video content was linked to each marker.
- **Augmented Reality Experience:** As users scan the title cards, Vuforia detects the markers and triggers the AR elements, creating an augmented reality video experience.

## Project Implementation

### Tools & Technologies
- **Unity**: Unity was used as the main development environment for integrating AR Core and Vuforia to build the AR app.
- **Vuforia**: Used for its powerful marker-based tracking capabilities, making it easy to recognize and track title cards.
- **Unity AR Core**: Ensured stable AR performance and robust environmental tracking.
- **Video Player Component**: Unity's Video Player component was utilized for video playback, seamlessly integrating with AR features.

### How It Works
1. **Image Recognition**: Users point their device camera at a movie title card.
2. **Marker Detection**: Vuforia recognizes the card as a unique marker.
3. **Video Playback**: The corresponding video is displayed on the card using the Unity Video Player component, giving the illusion that the card itself is playing the video.
4. **User Interaction**: Users can pause, stop, or replay the video by interacting with on-screen controls.

### System Requirements
- **Device Requirements**: Android or iOS devices with AR Core support and a working camera.
- **Software Requirements**: Unity 3D (2019 or later), Vuforia Engine SDK, AR Core SDK.

## Use Cases
- **Interactive Movie Promotion**: This project can be used as an innovative way to promote movies by allowing users to interact with movie posters or title cards.
- **Home Entertainment**: Users can create their own movie library and scan title cards to view trailers or bonus videos.

## Future Enhancements
- **Dynamic Video Content**: Integrate cloud recognition to dynamically link different videos to the same title card.
- **3D Model Augmentation**: Add 3D animations of key characters or scenes from the movie along with video playback for a richer AR experience.
- **User Interface Controls**: Enhance user interaction with on-screen controls for volume, play/pause, and other video settings.

## Contributors
- **Surendira Balaji N**

---

Feel free to use this description as a base and modify it to add any additional unique features or functionalities that your project might include.
