# My realization of backend task for https://prodcontest.ru

Running with docker compose:

```yaml
services:
  server:
    build:
      context: .
    image: ghcr.io/linuxfight/prodapi_2:master
    env_file:
      - .env
    ports:
      - "8080:8080"
    depends_on:
      - db
    networks:
      - app
    restart: unless-stopped
  db:
    image: postgres:alpine
    env_file:
      - .env
    volumes:
      - db-data:/var/lib/postgresql/data
    networks:
      - app
    restart: unless-stopped


volumes:
  db-data:

networks:
  app:
```

Also, you need to create ```.env``` file:

```
SERVER_ADDRESS=0.0.0.0:8080
POSTGRES_USER=postgres
POSTGRES_PASSWORD=password
POSTGRES_DB=db
POSTGRES_HOST=db
POSTGRES_PORT=5432
```