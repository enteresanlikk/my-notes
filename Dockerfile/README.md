- FROM
- RUN
- WORKDIR
- COPY
    - COPY --from=builder /app/build /usr/share/nginx/html
- EXPOSE
- CMD
- HEALTHCHECK
- ENV
- ADD
- ENTRYPOINT
- ARG
    - ARG VERSION -> using ${VERSION} -> --bıild-arg VERSION=1.0.0

docker image build -t bilaldemir111/hello .