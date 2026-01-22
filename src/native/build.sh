#!/bin/bash
# build.sh for custom-pinvoke-wasm (Linux/macOS)
set -e
BUILD_DIR="build-wasm"
BUILD_TYPE=${1:-Release}

emcmake cmake -B "$BUILD_DIR" -DCMAKE_BUILD_TYPE=$BUILD_TYPE
emmake cmake --build "$BUILD_DIR" -- -j$(nproc || sysctl -n hw.ncpu)
echo "Build finished in $BUILD_DIR"