# OpenWebDungeon
Open-Source Web-Based RPG Game

## Setup
To run OpenWebDungeon, use the `docker-compose.yml` that is in the `src` directory.

After deploying OWD, You'll want to expose the web panel through nginx (or whatever reverse proxy you prefer). It is recommended to also expose the API through your reverse proxy, so users can connect to your instance using third-party clients. If you want to only serve the game via it's web-panel, simply don't expose the API to the web. Communication between the web-panel and the api is done on the server-side through Remix.

The web client serves over port `80` and the api serves over port `8008`.

After the initial setup is complete, you'll want to import the asset pack into the `owd-data` volume. This is to ensure customizability by allowing hosters to create their own items for use in the game. A base asset pack has been included in this repository, under the `assets` directory.

## More info soon as development progresses.