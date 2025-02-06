from flask import Flask, jsonify

def rest():
    app = Flask(__name__)

    @app.route('/api/rest', methods=['GET'])
    def rest():
        return jsonify({"message": "Hello, this is your REST API!"})

    if __name__ == '__main__':
        app.run(debug=True)