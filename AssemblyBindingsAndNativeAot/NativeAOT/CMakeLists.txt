cmake_minimum_required(VERSION 3.10)
project(NativeAOT)

find_library(CSHARPLIB_PATH NAMES CSharpLib PATHS ${CMAKE_CURRENT_SOURCE_DIR}/CSharpLib/bin/Debug/net7.0/win-x64/native)
add_executable(native_aot main.c)

target_link_libraries(native_aot ${CSHARPLIB_PATH})