TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt
CONFIG += c++11

SOURCES += main.cpp \
    bintree.cpp \
    implementation.cpp \
    consolebintree.cpp \
    prettybintree.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    bintree.h \
    implementation.h \
    consolebintree.h \
    prettybintree.h

